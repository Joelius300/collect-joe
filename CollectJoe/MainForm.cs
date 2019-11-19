using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CollectJoe
{
    public partial class frmField : Form
    {
        private frmOptions _options = new frmOptions();
        private frmScoreList _scoreList;
        private frmEditScore _editScore;
        private Random _rnd = new Random();
        private int _playTime; 
        private int _timePlayed;
        private string _highScoreFilePath;
        private int _numberBoxesHorizontal;
        private int _numberBoxesVertical;
        private float _boxWidth;
        private float _boxHeight;
        private Color _boxColor;
        private List<BoxButton> _boxList = new List<BoxButton>();
        private int _indexLastOpened = 0;
        private Dictionary<Color, int> _dctColorAndValue = new Dictionary<Color, int>();
        private int[] _marginBoxInPanel = new int[] { 10, 10 };

        private char[] _charsToRemove = { ' ', 'P', '.', 'S', 'e', 'k'};
        private int _dummyForRnd;
        private int _gameOverAt;


        public frmField()
        {
            InitializeComponent();

            lblTime.Text = _playTime + " Sek.";

            _highScoreFilePath = Path.Combine(Environment.CurrentDirectory, "highscore.txt");
            if (!File.Exists(_highScoreFilePath)) {
                File.AppendAllText(_highScoreFilePath, "");
            }

            _scoreList = new frmScoreList(_highScoreFilePath);
            _editScore = new frmEditScore(_highScoreFilePath, this);

            SetOptions();
            BuildButtonField();

            _options.VisibleChanged += new EventHandler(BtnHideOptions_Click); 
        }
        private int GetPoints() {
            return Convert.ToInt32(lblPoints.Text.TrimEnd(_charsToRemove));
        }
        public void SetOptions() {
            //set backgroundcolor
            pnlField.BackColor = _options.GetColor("btnColorField");

            //set numbers of boxes in both directions
            _numberBoxesHorizontal = _options.GetHorizontal(); 
            _numberBoxesVertical = _options.GetVertical();

            //set boxwidth and boxheight
            _boxWidth = (pnlField.Width - _marginBoxInPanel[1] * 2f) / _numberBoxesHorizontal;
            _boxHeight = (pnlField.Height - _marginBoxInPanel[0] * 2f) / _numberBoxesVertical;

            //set boxcolor
            _boxColor = _options.GetColor("btnColorBox");

            //clear then fill dictionary
            _dctColorAndValue.Clear();
            for (int i = 1; i <= 3; i++)
            {
                _dctColorAndValue.Add(_options.GetColor("btnColorBoxType" + i), _options.GetValue("nudBoxType" + i));
            }

            if (_options.cbxFreedom.Checked)
            {
                tmrGame.Interval = _options.GetAdvancedOptions()["interval"];
                _playTime = _options.GetAdvancedOptions()["playTime"];
                _gameOverAt = _options.GetAdvancedOptions()["gameOverAt"];
            }
            else {
                _playTime = 40;  //no idea why you would put 39999 here (doesn't make sense in any time unit)
                tmrGame.Interval = 100;    //doesn't make sense (way too fast)
                _gameOverAt = 0;
            }

            lblTime.Text = _playTime + " Sek.";
        }

        public void StopGame() {
            tmrGame.Stop();
            tmrTime.Stop();
            ResetField();

            //eastereggs
            if (GetPoints() == 284 && _numberBoxesHorizontal == 20 && _numberBoxesVertical == 10)
            {
                Eastereggs.Celia(this);
            }
            else if (GetPoints() > 9000)
            {
                Eastereggs.Over9000();
            }

            if (GetPoints() < _gameOverAt)
            {
                MessageBox.Show("Game Over!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else {
                _editScore.SetScore(Convert.ToString(GetPoints()));
                _editScore.ShowDialog();
            }

            btnStart.Text = "Spiel starten";

            btnOptions.Enabled = true;
            btnScoreList.Enabled = true;
        }

        private void BtnBox_Click(object sender, EventArgs e) {
            if (tmrTime.Enabled)
            {
                if (_dctColorAndValue.ContainsKey((sender as Button).BackColor))
                {
                    lblPoints.Text = Convert.ToString(GetPoints() + _dctColorAndValue[(sender as Button).BackColor]) + " P.";

                    //prevents people from clicking on a button twice
                    tmrGame.Stop();
                    tmrGame.Start();
                    TmrGame_Tick(tmrGame, EventArgs.Empty);
                }
                if (GetPoints() < _gameOverAt)
                {
                    StopGame();
                }
            }
        }

        private Point CalcLocation(int i, int j)
        {
            return new Point(Convert.ToInt16(j * _boxWidth + _marginBoxInPanel[0]), Convert.ToInt16(i * _boxHeight + _marginBoxInPanel[1]));
        }

        public void BuildButtonField() {
            pnlField.Controls.Clear();
            foreach (BoxButton btn in _boxList)
            {
                btn.Dispose();
            }
            _boxList.Clear();

            for (int i = 0; i < _numberBoxesVertical; i++)
            {
                for (int j = 0; j < _numberBoxesHorizontal; j++)
                {
                    BoxButton btn = new BoxButton
                    {
                        Name = "btn_" + Convert.ToString(i * _numberBoxesHorizontal + j + 1),
                        Height = (int)_boxHeight,
                        Width = (int)_boxWidth,
                        Location = CalcLocation(i, j),
                        BackColor = _boxColor
                    };

                    btn.Click += new EventHandler(BtnBox_Click);

                    pnlField.Controls.Add(btn);
                    _boxList.Add(btn);
                }
            }
        }

        //for eastereggs
        public void DrawOnField(int[] indexlist) {
            ResetField();
            foreach (int index in indexlist)
            {
                _boxList[index].BackColor = _dctColorAndValue.ElementAt(_rnd.Next(0, _dctColorAndValue.Count)).Key;
            }
        }

        //for eastereggs
        public void DrawOnField(int[] indexlist, Color color)
        {
            ResetField();
            foreach (int index in indexlist)
            {
                _boxList[index].BackColor = color;
            }
        }

        private void ResetField() {
            foreach (Button btn in _boxList)
            {
                if (btn.BackColor != _boxColor) { btn.BackColor = _boxColor; };
            }
        }

        private void BtnHideOptions_Click(object sender, EventArgs e)
        {
            if (!(sender as frmOptions).Visible) {
                SetOptions();
                BuildButtonField();
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            _options.ShowDialog();
        }

        public void BtnScoreList_Click(object sender, EventArgs e)
        {
            _scoreList.RefreshScore();
            _scoreList.ShowDialog();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnOptions.Enabled = false;
            btnScoreList.Enabled = false;

            _timePlayed = 0;
            _indexLastOpened = 0;
            lblPoints.Text = "0 P.";
            lblTime.Text = _playTime + " Sek.";
            _editScore.ReSetNameAndScore();

            ResetField();

            btnStart.Text = "Spiel neustarten";

            tmrGame.Start();
            tmrTime.Start();
            TmrGame_Tick(tmrGame, EventArgs.Empty);
        }

        private void TmrGame_Tick(object sender, EventArgs e)
        {
            //reset the field with the least possible effort
            _boxList[_indexLastOpened].BackColor = _boxColor;

            //choose random index to get random button -> set backcolor to random color -> refresh the index for next round.
            _dummyForRnd = _rnd.Next(0, _boxList.Count); //it has to be the same number twice
            _boxList[_dummyForRnd].BackColor = _dctColorAndValue.ElementAt(_rnd.Next(0, _dctColorAndValue.Count)).Key;
            _indexLastOpened = _boxList.IndexOf(_boxList[_dummyForRnd]);
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            _timePlayed++;
            lblTime.Text = (_playTime - _timePlayed) + " Sek.";

            if (_playTime - _timePlayed == 0)
            {
                StopGame();
            }
        }

        private void LblTime_MouseHover(object sender, EventArgs e)
        {
            if (lblTime.Text.TrimEnd(_charsToRemove) == "284" && !tmrGame.Enabled)
            {
                Eastereggs.IHeartC(this);
            }
        }
    }
}
