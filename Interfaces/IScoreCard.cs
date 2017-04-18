using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniux.CMS;
using Ingeniux.CMS.RavenDB.Indexes;

namespace ExtensionExample
{
    public interface IScoreCard : IEntity<IVentureCoManager>
    {
       int Score { get; set; }
    }
}
