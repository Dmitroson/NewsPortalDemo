using FluentNHibernate.Mapping;

namespace NewsPortal.Models.ClassMap
{
    public class ApplicationUserMap : ClassMap<ApplicationUser>
    {
        public ApplicationUserMap()
        {
            Table("AspNetUsers");
            Id(u => u.Id);
            Map(u => u.UserName);
            HasMany(u => u.Comments).Inverse();
        }
    }
}