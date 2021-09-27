using System;
using System.IO;

namespace jukebox.webapi
{
    public class Music
    {
        public string unfaithful { get; set; }
        public string believer { get; set; }
        public string lovely {get; set; }
        public string trampoline {get; set; }


            public Music() 
            {

                    if(File.Exists("unfaithful.txt"))
                    {    
                        unfaithful = File.ReadAllText("unfaithful.txt"); 
                    } 
                                      
                    else                                      
                    {             
                        unfaithful = "??";     
                    }

                    if(File.Exists("trampoline.txt"))
                    {    
                        trampoline = File.ReadAllText("trampoline.txt"); 
                    } 
                                      
                    else                                      
                    {             
                        trampoline = "??";     
                    }

                    if(File.Exists("believer.txt"))
                    {    
                        believer = File.ReadAllText("believer.txt"); 
                    } 
                                      
                    else                                      
                    {             
                        believer = "??";     
                    }

                     if(File.Exists("lovely.txt"))
                    {    
                        lovely = File.ReadAllText("lovely.txt"); 
                    } 
                                      
                    else                                      
                    {             
                        lovely = "??";     
                    }
            }
    }
}


    