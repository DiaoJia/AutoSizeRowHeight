using System;
namespace AutoSizeRowHeight
{
    public class GrowItem
    {
		public string ImageName { get; set; } = "";
		public string Title { get; set; } = "";
		public string Description { get; set; } = "";
		
		public GrowItem()
		{
		}

		public GrowItem(string imageName, string title, string description)
		{			
			this.ImageName = imageName;
			this.Title = title;
			this.Description = description;
		}
		
	}
}
