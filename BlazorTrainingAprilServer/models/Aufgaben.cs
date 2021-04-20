using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorTrainingAprilServer.models
{
    public partial class Aufgaben
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Erledigt { get; set; }
        public bool IsErledigt { get; set; }
    }
}
