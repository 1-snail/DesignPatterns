using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverPattern
{
    internal class Subject : ISubject
    {
        private List<IObserver>  _obervers = new List<IObserver>();

        // 类中一些其他逻辑所用的变量
        public int state { get; set; } = 0;
        public void Attach(IObserver observer)
        {
            _obervers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _obervers?.Remove(observer);
        }

        /// <summary>
        /// 通知所有的 observer 
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _obervers)
            {
                // 将自身状态传递给观察者【也可以是参数】
                observer.Update(this);
            }
        }

        /// <summary>
        /// 一些其他逻辑,该逻辑会触发变量改变，然后引发通知
        /// </summary>
        public void  SomeLogic()
        {
            Random random = new Random();
            state = random.Next(0,10);
            this.Notify();
        }
    }
}
