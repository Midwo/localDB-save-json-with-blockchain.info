using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWalut
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public class BitCoinContext : DbContext
        {

            public BitCoinContext() : base("BitCoinKurs")
            {
                Database.SetInitializer<BitCoinContext>(new BitCoinInf());

   
            }

            public DbSet<BitCoinClass> BitCoinx { get; set; }
        }

        public class BitCoinInf : DropCreateDatabaseIfModelChanges<BitCoinContext>
        {

            protected override void Seed(BitCoinContext context)
            {

                base.Seed(context);
            }
        }
    }
}
