using System.Web.Mvc;
using CodeCampServer.Core.Domain;
using CodeCampServer.Core.Domain.Model;
using CodeCampServer.UI.Models.Input;

namespace CodeCampServer.UI.Helpers.Mappers
{
	public interface IUserGroupSponsorMapper : IMapper<UserGroup, SponsorInput>
	{
		SponsorInput[] Map(Sponsor[] sponsors);
		SponsorInput Map(Sponsor sponsor);
	}
}