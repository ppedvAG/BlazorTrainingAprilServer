using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTrainingAprilServer.Pages.Modul03
{
    public class ChatVM
    {
        public List<string> ChatListe { get; set; } = new List<string>();
        public Action OnAdd;
        void Add(string msg)
        {
            ChatListe.Add(msg);
            OnAdd?.Invoke();

        }

    }
}
