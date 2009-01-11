using System;
using CodeCampServer.Core.Domain;
using CodeCampServer.Core.Domain.Model;
using CodeCampServer.UI.Helpers.Mappers;
using CodeCampServer.UI.Models.Forms;

namespace CodeCampServer.UI.Helpers.Mappers
{
	public class ConferenceMapper : FormMapper<Conference, ConferenceForm>, IConferenceMapper
	{
		private readonly IConferenceRepository _repository;

		public ConferenceMapper(IConferenceRepository repository) : base(repository)
		{
			_repository = repository;
		}

		protected override Guid GetIdFromMessage(ConferenceForm form)
		{
			return form.Id;
		}

		protected override void MapToModel(ConferenceForm form, Conference model)
		{
			model.Address = form.Address;
			model.City = form.City;
			model.Key = form.Key;
			model.Description = form.Description;
			model.EndDate = ToDateTime(form.EndDate);
			model.LocationName = form.LocationName;
			model.Name = form.Name;
			model.PhoneNumber = form.PhoneNumber;
			model.PostalCode = form.PostalCode;
			model.Region = form.Region;
			model.StartDate = ToDateTime(form.StartDate);
		}
	}
}