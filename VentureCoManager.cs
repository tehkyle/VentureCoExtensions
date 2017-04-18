using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ingeniux.CMS;

namespace ExtensionExample
{
    public class VentureCoManager : TransactionalEntity, IVentureCoManager
    {
        public VentureCoManager(IUserSession session) : base(session) { }

        public void CreateCard(ScoreCard newCard)
        {
            Create<ScoreCard, IVentureCoManager>(newCard);
        }

        public override XElement Serialize()
        {
            return new XElement("VentureCo");
        }
    }
}
