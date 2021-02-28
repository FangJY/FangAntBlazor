using System.Collections.Generic;
using System.Threading.Tasks;
using antBlazor.Models;
using antBlazor.Services;
using Microsoft.AspNetCore.Components;
using AntDesign;

namespace antBlazor.Pages.List
{
    public partial class Projects
    {
        private readonly ListGridType _listGridType = new ListGridType
        {
            Gutter = 24,
            Column = 4
        };

        private readonly ListFormModel _model = new ListFormModel();

        private IList<ListItemDataType> _fakeList = new List<ListItemDataType>();

        [Inject] public IProjectService ProjectService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _fakeList = await ProjectService.GetFakeListAsync(8);
        }
    }
}