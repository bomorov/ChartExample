using System.Collections.Generic;

namespace ChartExample.Models
{
    public class ChartDataModel<TModel>
    {
        public string Title { get; set; }
        public List<TModel> ChartDataList { get; set; }
    }

    public class CharItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
