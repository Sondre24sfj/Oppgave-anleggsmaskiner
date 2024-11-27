using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AnleggsmaskinerSite.RazorPages
{
     public class IndexModel : PageModel
     {
        public list<Maskin> Maskiner {get; set;}

        public void OnGet()
        { 
            Maskiner = new List<Maskin>
            { 
                new Maskin { Volvo EC300El = "Gravemaskin",  "Gravemaskin som er fin til å gjøre litt større jobber", Pris = 1 250 000 },
                new Maskin { Volvo L180H = "Hjullaster", "Hjullaster som er effektiv til å transportere matrialer", Pris = 900 000 },
                new Maskin { Volvo A30G = "Dumper", "Dumperen er fin til å flytte større matrialer som skal fraktes lenger", Pris = 2 990 000},
            };

        }
     }
    

public class Maskin
{
    public string Volvo { get; set; }
    public string Beskrivelse { get; set }
    public interface Pris { get; set; }
}
}

     
    
