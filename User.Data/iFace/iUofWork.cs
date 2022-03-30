using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Data.iFace
{
    public interface iUofWork : IDisposable
    {
        isUser userdata { get; }
        isplitUser splituser { get; }
        ipayment ipayments { get; }  
        int complete();

    }
}
