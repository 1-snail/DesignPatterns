using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverPattern
{
    interface IObserver
    {
        // 接收来自 subject 的更新,例如subject一些参数更新了，可以获得改该更新
        void Update(ISubject subject);

    }
}
