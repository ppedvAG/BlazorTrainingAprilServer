using BlazorTrainingAprilServer.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTrainingAprilServer.Pages.Modul04
{
    public class AufgabenVM
    {
        TodoDBContext db;
        public List<Aufgaben> AufgabenListe { get; set; }
        public Action OnAufgabenChanged;

        public AufgabenVM([FromServices] TodoDBContext _db)
        {
            db = _db;
            AufgabenListe = db.Aufgabens.ToList();
        }
        public void Add()
        {
            //todo speichern Logik

            OnAufgabenChanged?.Invoke();
        }


    }
}
