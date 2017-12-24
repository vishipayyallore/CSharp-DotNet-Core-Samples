using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncReturnDemo

{
    public partial class Form1 : Form
    {
        private double timerTtl = 10.0D;
        private DateTime timeToLive;
        private int cacheValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = $"Timer TTL {timerTtl} sec (STOPPED)";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerTtl == 0)
            {
                timerTtl = 5;
            }
            else
            {
                timerTtl -= 1;
            }
            lblTimer.Text = $"Timer TTL {timerTtl} sec (RUNNING)";
        }


        public async Task<int> GetValue()
        {
            await Task.Delay(1000);

            var random = new Random();
            cacheValue = random.Next();
            timeToLive = DateTime.Now.AddSeconds(timerTtl);

            timer1.Start();
            return cacheValue;
        }

        public ValueTask<int> LoadReadCache(out bool isValueCached)
        {
            if (timeToLive < DateTime.Now)
            {
                isValueCached = false;
                return new ValueTask<int>(GetValue());
            }
            isValueCached = true;
            return new ValueTask<int>(cacheValue);
        }
        
    }
}
