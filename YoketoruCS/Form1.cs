using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int EnemyMax => 4;//敵の方を先に宣言する(プレイヤーと敵は出っぱなしなため)
        static int ItemMax => 4;

        static int PlayerIndex => 0;
        static int EnemyIndex => PlayerIndex + PlayerMax;//1+0=1
        static int ItemIndex => EnemyIndex + EnemyMax;//1+4=5
        static int LabelMax => ItemIndex + EnemyMax;//5+4=9

        Label[] labels = new Label[LabelMax];

        static Random random = new Random();

        int[] vx = new int[LabelMax];
        int[] vy = new int[LabelMax];

        static int SpeedMax => 10;

        int score = 0;
        int timer = 0;

        int Visiblecounter = ItemIndex;
        int highscore;

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }
        /// <summary>
        /// 次に切り替えたい状態
        /// </summary>
        State nextState = State.Title;

        /// <summary>
        /// 現在の状態
        /// </summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < LabelMax; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Visible = false;
                Controls.Add(labels[i]);

                tempplayer.Visible = false;
                tempEnemy.Visible = false;
                tempitem.Visible = false;

                // Text, Font, ForeColorを、種類ごとに設定したい!!
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
                    labels[i].Left = labels[i - 1].Left + labels[i - 1].Width;
                }
                if (i >= ItemIndex)
                {
                    labels[i].Text = tempitem.Text;
                    labels[i].Font = tempitem.Font;
                    labels[i].ForeColor = tempitem.ForeColor;
                    labels[i].Left = labels[i - 1].Left + labels[i - 1].Width;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitState();
            UpdateState();
            UpdateChrs();
        }

        void InitState()
        {

            if (nextState == State.None)
            {
                return;//実行されたらメソッドを抜け、呼び出し元に処理を戻す
            }
            currentState = nextState;
            nextState = State.None;

            // 初期化処理
            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;

                    labelGameover.Visible = false;
                    buttonToTitle.Visible = false;
                    labelClear.Visible = false;

                    //ハイスコア判定
                    if (score > highscore)
                    {
                        highscore = score;
                    }
                    labelhighscore.Text = $"ハイスコア:{highscore}";

                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;

                    for (int i = 0; i < LabelMax; i++)
                    {
                        labels[i].Visible = true;

                        labels[i].Left = random.Next(0, ClientSize.Width - labels[i].Width);
                        labels[i].Top = random.Next(0, ClientSize.Height - labels[i].Height);

                        vx[i] = random.Next(-SpeedMax, SpeedMax);
                        vy[i] = random.Next(-SpeedMax, SpeedMax);
                    }
                    score = 0;
                    timer = 200;

                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;
                    for (int i = 0; i < LabelMax; i++)
                    {
                        vx[i] = 0;
                        vy[i] = 0;
                    }
                    Visiblecounter = ItemIndex;

                    break;
                case State.Clear:
                    labelClear.Visible = true;
                    buttonToTitle.Visible = true;
                    for (int i = 0; i < LabelMax; i++)
                    {
                        vx[i] = 0;
                        vy[i] = 0;
                    }
                    Visiblecounter = ItemIndex;

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

            //プレイヤー移動
            var fpos = PointToClient(MousePosition);
            labels[PlayerIndex].Left = fpos.X - labels[PlayerIndex].Width / 2;
            labels[PlayerIndex].Top = fpos.Y - labels[PlayerIndex].Height / 2;

            //キャラクターの更新
            UpdateChrs();
            timer--;
            labelTime.Text = $"{timer}";
            if (timer <= 0)
            {
                nextState = State.Gameover;
            }
            for (int i = EnemyIndex; i < LabelMax; i++)
            {

                //PlayerのLabelと重なっているか判断
                if ((fpos.X > labels[i].Left)
                && (fpos.Y > labels[i].Top)
                && (fpos.X < labels[i].Right)
                && (fpos.Y < labels[i].Bottom))
                {
                    if (i > PlayerIndex && i < ItemIndex)//重なったLabelが敵の場合
                    {
                        nextState = State.Gameover;
                    }
                    else//敵じゃなければアイテム扱い
                    {
                        //得点加算
                        score += timer * 100;
                        labelScore.Text = $"{score}";
                        if (labels[i].Visible == true)
                        {
                            //取ったアイテムのラベルを非表示にする
                            labels[i].Visible = false;
                            Visiblecounter++;
                        }
                        //全部のアイテムをとったらゲームクリア
                        if (Visiblecounter == LabelMax)
                        {
                            nextState = State.Clear;
                        }
                    }
                }
            }
        }

        void UpdateChrs()
        {
            //アイテムと敵の移動

            for (int i = EnemyIndex; i < LabelMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Left > (ClientSize.Width - labels[i].Width))
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Top > (ClientSize.Height - labels[i].Height))
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
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