using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncReturnDemo

{
    public partial class Form1 : Form
    {
        private double _timerTtl = 10.0D;
        private DateTime _timeToLive;
        private int _cacheValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = $@"Timer TTL {_timerTtl} sec (STOPPED)";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (_timerTtl == 0)
            {
                _timerTtl = 10;
            }
            else
            {
                _timerTtl -= 1;
            }
            lblTimer.Text = $@"Timer TTL {_timerTtl} sec (RUNNING)";
        }


        private async Task<int> GetValue()
        {
            await Task.Delay(1000);

            var random = new Random();
            _cacheValue = random.Next();
            _timeToLive = DateTime.Now.AddSeconds(_timerTtl);

            timer1.Start();
            return _cacheValue;
        }

        private ValueTask<int> LoadReadCache(out bool isValueCached)
        {
            if (_timeToLive < DateTime.Now)
            {
                isValueCached = false;
                return new ValueTask<int>(GetValue());
            }
            isValueCached = true;
            return new ValueTask<int>(_cacheValue);
        }

        private async void btnTestAsync_Click(object sender, EventArgs e)
        {
            var returnValue = await LoadReadCache(out bool isCachedValue);
            txtOutput.Text = isCachedValue ? $"Cached value {returnValue} read." : $"New value {returnValue} read.";
        }
    }
}
