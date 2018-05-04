using System;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace Isen.Cs.Library
{
    public class MyCollection: IMyCollection
    {
        //Tableau de persistance de la collection
        private string[] _values;

        //Ctor
        public MyCollection()
        {
            _values = new string[0];
        }
        
        //getter avec syntawxe expression-body
        public int Count => _values.Length;
        //pareil (accès au tableau des valeurs)
        public string[] Values => _values;

        public void Add(string item)
        {
            //tableau temporaire de taille count+1
            var tmp = new string[Count + 1];
            // Copier les valeurs existances 
            for (int i = 0; i < Count; i++) tmp[i] = _values[i];
            //Ajouter la nouvelle valeur dans la dernière case
            tmp[tmp.Length - 1] = item;
            //Réaffecter le tableau
            _values = tmp;
        }

        public void InsertAt(int index, string item)
        {
            if (index < 0 || index > Count) throw new IndexOutOfRangeException();
            //tableau temportaire de taille count +1
            var tmp = new string[Count + 1];
            // Parcourir avant la césure
            for (int i = 0; i < index; i++)
            {
                //avant la césure 
                tmp[i] = _values[i];
            }
            // A la césure : nouvelle valeur 
            tmp[index] = item;
            //Après la césure : affection déccalée 
            for (var i = index + 1; i < tmp.Length; i++)
            {
                tmp[i] = _values[i - 1];
            }
            //réaffecter le tableau
            _values = tmp;

        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }

    #region Explication des propriétés, getter and setter

//    public class MyClass
//        {
//            private int _myInt;
//            
//            //getter and setter #C# explicite
//            public int MyInt
//            {
//                get { return _myInt; }
//                private set { _myInt = value; }
//            }
//            
//            //get and set implicite
//            public string MyString { get; set; }
//            
//            //getter and setter #JAVA
//            public int getMyInt()
//            {
//                return getMyInt();
//            }
//
//            private void setMyInt(int value)
//            {
//                _myInt = value;
//            }
//        }

#endregion
    
}