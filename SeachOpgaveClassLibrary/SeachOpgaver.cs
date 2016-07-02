using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeachOpgaveClassLibrary
{
    public class SeachOpgaver
    {
        private List<int> IntList = new List<int>();
        public void FillList(IEnumerable<int> elementer)   // IEnumerable<int>  generel type der kan gennemløbes med foreach
        {
            IntList.AddRange(elementer);
        }

        public int FindPositionInList_Unsorted_Sequential(int seachValue)
        {
            // Precondition: 
            //      IntList forudsættes at være usorteret
            // Postcondition:
            //      metoden skal returnere positionen/index på element i IntList som har værdien searchValue
            //      hvis IntList ikke indeholder nogen elementer (er tom) skal der returneres -1
            //      Hvis værdien ikke findes i IntList skal der returneres -1
            //

            // programmer metoden, idet du her skal bruge sekventiel / linær søgning 

            return -2; //  throw new NotImplementedException();

        }
        public int FindPositionInList_Sorted_Sequential(int seachValue)
        {
            // Precondition: 
            //      IntList forudsættes at være sorteret
            // Postcondition:
            //      metoden skal returnere positionen/index på element i IntList som har værdien searchValue
            //      hvis IntList ikke indeholder nogen elementer (er tom) skal der returneres -1
            //      Hvis værdien ikke findes i IntList skal der returneres -1
            //

            // programmer metoden, idet du her skal bruge sekventiel / linær søgning 
            // optimer så du tager hensyn til listen er sorteret - du kan stoppe når listens værdier bliver større end det du søger efter

            return -2; //  throw new NotImplementedException();

        }

        public int FindPositionInList_Sorted_Binary(int seachValue)
        {
            // Precondition: 
            //      IntList forudsættes at være sorteret
            // Postcondition:
            //      metoden skal returnere positionen/index på element i IntList som har værdien searchValue
            //      hvis IntList ikke indeholder nogen elementer (er tom) skal der returneres -1
            //      Hvis værdien ikke findes i IntList skal der returneres -1
            //

            // programmer metoden, idet du her skal bruge binær søgning (loop - ikke recursion)

            return -2; //  throw new NotImplementedException();

        }

        public int FindPositionInList_Sorted_Binary_RecursiveStart(int seachValue)
        {
            // Hjælpemetode for opstart så man ikke skal kende listen uden for klassen - Kunne hedde det samme som den recursive, da der er forskellige paramertere
            return FindPositionInList_Sorted_Binary_Recursive(0,IntList.Count,seachValue);
        }
        public int FindPositionInList_Sorted_Binary_Recursive(int firstPosition, int lastPosition, int seachValue)
        {
            // Precondition: 
            //      IntList forudsættes at være sorteret
            // Postcondition:
            //      metoden skal returnere positionen/index på element i IntList som har værdien searchValue
            //      hvis IntList ikke indeholder nogen elementer (er tom) skal der returneres -1
            //      Hvis værdien ikke findes i IntList skal der returneres -1
            //

            // programmer metoden, idet du her skal bruge binær søgning og en recursiv løsning

            return -2; //  throw new NotImplementedException();

        }


    }
}
