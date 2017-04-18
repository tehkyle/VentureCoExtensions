using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ingeniux.CMS;
using Ingeniux.CMS.RavenDB.Indexes;

namespace ExtensionExample
{
    public class ScoreCard : Entity<IVentureCoManager>, IScoreCard
    {
        public ScoreCard() : base() { }

        public ScoreCard(IPage page, IUserSession session) : this()
        {
            Analyze(page);
            UserId = session.OperatingUser.UserId;
            PageId = page.Id;
        }

        public int Score
        {
            get;
            set;
        }

        public string UserId { get; set; }

        public string PageId { get; set; }

        public void Analyze(IPage page)
        {
            Random rand = new Random();
            Score = rand.Next(1, 100);
        }

        public override XElement Serialize()
        {
            return new XElement("ScoreCard");
        }

        public override void ValidateData()
        {
            return;
        }

        public override void ValidateUserPermission(IUser user)
        {
            return;
        }
    }
}
