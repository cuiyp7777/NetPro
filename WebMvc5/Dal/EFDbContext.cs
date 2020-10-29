using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMvc5.Models;

namespace WebMvc5.Dal
{
    public class EFDbContext : DbContext
    {
        /// <summary>
		/// 构造函数中的 base("AccountContext") 。
		/// 默认情况下和类名一样，即AccountContext，我们显式的给他指定出来。
		/// </summary>
		public EFDbContext()
            : base("ChanJoyDBContext")
        {
        }
        public DbSet<Administrator_Module_Mapping> Administrator_Module_Mapping { get; set; }
    }
}