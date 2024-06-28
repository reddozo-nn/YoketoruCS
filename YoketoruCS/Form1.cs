using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int EnemyMax => 4;//�G�̕����ɐ錾����(�v���C���[�ƓG�͏o���ςȂ��Ȃ���)
        static int ItemMax => 4;

        static int PlayerIndex => 0;
        static int EnemyIndex => PlayerIndex + PlayerMax;//1+0=1
        static int ItemIndex => EnemyIndex + EnemyMax;//1+4=5
        static int LabelMax => ItemIndex + EnemyMax;//5+4=9

        Label[] labels = new Label[LabelMax];

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }
        /// <summary>
        /// ���ɐ؂�ւ��������
        /// </summary>
        State nextState = State.Title;

        /// <summary>
        /// ���݂̏��
        /// </summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < LabelMax; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                Controls.Add(labels[i]);

                // Text, Font, ForeColor���A��ނ��Ƃɐݒ肵����!!
                if (i == PlayerIndex)
                {
                    labels[i].Text = tempplayer.Text;
                    labels[i].Font = tempplayer.Font;
                    labels[i].ForeColor = tempplayer.ForeColor;
                }
                else if (i > PlayerIndex && i < ItemIndex)
                {
                    labels[i].Text = tempEnemy.Text;
                    labels[i].Font = tempEnemy.Font;
                    labels[i].ForeColor = tempEnemy.ForeColor;
                        labels[i].Location = new Point(100 + i * 35, 50);
                }
                if (i >= ItemIndex && i < LabelMax)
                {
                    labels[i].Text = tempitem.Text;
                    labels[i].Font = tempitem.Font;
                    labels[i].ForeColor = tempitem.ForeColor;
                    labels[i].Location = new Point(100 + i * 35, 75);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitState();
            UpdateState();
        }

        void InitState()
        {
            if (nextState == State.None)
            {
                return;//���s���ꂽ�烁�\�b�h�𔲂��A�Ăяo�����ɏ�����߂�
            }
            currentState = nextState;
            nextState = State.None;

            // ����������
            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;

                    labelGameover.Visible = false;
                    buttonToTitle.Visible = false;
                    labelClear.Visible = false;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;
                    break;
                case State.Clear:
                    labelClear.Visible = true;
                    buttonToTitle.Visible = true;
                    break;

            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttonToTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void tempitem_Click(object sender, EventArgs e)
        {

        }
    }
}