using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComparerApp.LibrarySnd;
using ComparerApp.LibrarySnd.ServicesInterfaces;

namespace ComparerApp.ForWinForms
{
    public partial class Form1 : Form
    {
        private ParticipatorsContainer PContainer;
        private Round PRound;
        private IDecisionManager DecisionManager;
        private IComparerPreparator Preparator;

        private PreviousState ThePreviousState;

        public Form1(IDecisionManager decisionManager, IComparerPreparator preparator)
        {
            InitializeComponent();
            CenterToScreen();

            DecisionManager = decisionManager;
            Preparator = preparator;

            DrawInitialState(preparator);
        }

        private void AnyPictureBox_Click(object sender, EventArgs e)
        {
            ThePreviousState.InitializePreviousState(PRound, PContainer);

            PictureBox tmp = (PictureBox)sender;
            string choice = tmp.Name;
            ObjectParticipator choosedObject = DecisionManager.MakeDecision(choice, PRound, PContainer);

            ThePreviousState.UpdateObjectsLists(choosedObject);

            if (DecisionManager.CheckWinCondition(PContainer))
            {
                MessageBox.Show($"The winner is {PContainer.NextRoundObjectsArray[0].FileName}!\nNow the program will restart the survey.");
                DrawInitialState(Preparator);
            }

            PRound = DecisionManager.CreateNewRoundIfNeeded(PRound, PContainer);
            UpdatePicturesAndLabels();
        }

        private void UpdatePicturesAndLabels()
        {
            pictureBox1.Image = new Bitmap(Image.FromFile(PRound.Pairs[0].First().FileDirectory), pictureBox1.Size);
            pictureBox1.Name = PRound.Pairs[0].First().FileName;
            pictureBox2.Image = new Bitmap(Image.FromFile(PRound.Pairs[0].Last().FileDirectory), pictureBox2.Size);
            pictureBox2.Name = PRound.Pairs[0].Last().FileName;

            labelNameLeft.Text = PRound.Pairs[0].First().FileName;
            labelNameRight.Text = PRound.Pairs[0].Last().FileName;

            labelStage.Text = "Stage: " + PRound.Stage;
            labelRound.Text = "Round: " + PRound.RoundNumber.ToString() + " out of " + (PRound.Pairs.Count + PContainer.NextRoundObjectsArray.Count);
        }

        private void DrawInitialState(IComparerPreparator preparator)
        {
            PContainer = new ParticipatorsContainer();
            try
            {
                PContainer = preparator.Prepare(); //есть контейнер файлов, в котором есть имя и полный путь каждого файла из папки
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            PContainer.RemainderOfInitialCapacity = PContainer.Capacity;

            PRound = preparator.CreateRound(PContainer.Capacity, PContainer.ObjectsArray);

            UpdatePicturesAndLabels();

            ThePreviousState = new PreviousState();
        }

        #region MenuItems
        private void fullRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawInitialState(Preparator);
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawPreviousState();
        }
        #endregion

        private void DrawPreviousState()
        {
            if (ThePreviousState.ChoosedObjects.Any())
            {
                ThePreviousState.RestorePreviousState(ref PRound, ref PContainer);
                UpdatePicturesAndLabels();
            }
        }
    }
}
