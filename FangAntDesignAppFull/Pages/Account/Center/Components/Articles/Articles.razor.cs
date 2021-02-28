using System.Collections.Generic;
using antBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace antBlazor.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}