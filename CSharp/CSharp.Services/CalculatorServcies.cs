using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Services
{
    public class CalculatorServcies : IDisposable
    {

        public async Task<int> Add()
        {
            Task task = new Task(() =>
            {
                Thread.Sleep(2000);
            });
            task.Start();
            await task;
            return 10;
        }

        public async Task<int> Calc()
        {
            Task task = new Task(() => {
                Thread.Sleep(3000);
            });
            task.Start();
            await task;
            return 20;
        }

        public void Dispose()
        {

        }
    }
}
