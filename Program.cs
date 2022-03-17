using System;
using System.IO;
using System.Text;

namespace Le_Jeu_Du_Pendu
{
    class Program
    {
        //The char type supports comparison, equality,
        //increment, and decrement operators.
        //Moreover, for char operands,
        //arithmetic and bitwise
        //logical operators perform
        //an operation on the corresponding character codes and produce the result of the int type.//

        //The string type represents text as a sequence of char values.//
        static void Main(string[] args)
        {
           int vies = Vies();
            Mots();
            string Mot = TableauMotsRef();
            string Underscore = Underscores();
            string TableauU = TableauUnderscore(Mot, Underscore, vies);
            Verify_Input( TableauU, vies,  Mot);


        }

        static string TableauMotsRef()
        {
            var ListeMots = new[] {"Prendre", "Toupie","Feu", " Eau", "Terre","Air","Frapper","Hippopotomonstrosesquipedaliophobie",
            "jouet" , "Hexakosioihexekontahexaphobie ", "film", "photographie", "Cookie" , "Montre", "Ordinateur", "Paradigme",
            "Fenetre", "Masque", "Maison", "Manoir"};
            Random rnd = new Random();
            int Mot = rnd.Next(ListeMots.Length);
            return ListeMots[Mot];
        }


        static string TableauUnderscore(string word, string Underscore, int vies)
        {
           
            Underscore = ("_");
            
            string Space = (" ");
            char tiréduHuit = char.Parse(Underscore);
            string tiréduHuitS = tiréduHuit.ToString();
          

            Console.WriteLine(" ");

            foreach (char lettres in word)
            {
                Console.Write(Underscore + Space);
            }
            char[] Tableau = word.ToCharArray();
               string TableauU = word;


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Entrez une lettre :");
            Console.WriteLine(" ");
            return TableauU;
        }   
            
 //------------------------------------------ Manque juste à faire boucler la boucle de Gameplay pour pouvoir rejouer--------------------------------------//
        static string Verify_Input(string TableauU, int vies,  string Mot)
        {
            int T_Lenght = TableauU.Length;
            
            string L = ("_");
            char Underscore1 = char.Parse(L);
            string L_Underscore1 = Underscore1.ToString();
            int U_Lenght = L_Underscore1.Length;

            

                                                                             // remplacer la string par un tableau qui as la taille de TableauU//
                                                                     // il faut que mon tableau de char Underscore 1 soit égale à la longeur de tableauU//

            string LettreJoueurs = Console.ReadLine();
            char InputJoueur = char.Parse(LettreJoueurs);
                char[] C_TableauU = TableauU.ToCharArray();

            for (int i = 0; i < TableauU.Length; i++)
            {
                if (LettreJoueurs != TableauU)                          // Temporaire sert seulement de test
                {
                   
                    
                    Console.Write(TableauU[i] + " ");
                }

            }   
                  
                 
                    
                
               
                
              
                

                      
                
               
                    
            
          

                return LettreJoueurs;           
        }
            

                
                       
                    

                        
           
           

            
        

        

        static int Vies()
        {
            Console.WriteLine(" Le jeu du pendu commence !");
            Console.WriteLine(" ");
            int vies = 6;
            Console.WriteLine("Vies Restantes :" +" "+ vies);
            return vies;
        }

        static string Underscores()
        {
            string Underscore = ("_");
            return Underscore;
        }
        static void Mots()
        {
            Console.WriteLine("Le mot ne contient pas les lettres :");
        }


    }
}
