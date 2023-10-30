

namespace PhoneBook
{
    internal class PhoneBook
    {
        //instance variables:
        private string[] names = { "David", "Lauren", "Jack", "Mary", "Liliya" };
        private string[] phones = { "0770112113", "0770456353", "0770458789", "0770365521", "0770145256", }; 
        private string[,] phoneList;// here we creating a two dimensional array

        /// <summary> 3.3
        /// This method will display the list of names and phone number:
        /// </summary>
        private void displayList()
        {
            //looping through the names
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " " + phones[i] );
                /*string result = string.Format("{ 0, -15} {1, -15}", names[i], phones[i]);
                Console.WriteLine(result);*/
            } 
        }

        /// <summary>
        /// bubble sort
        /// </summary>
        private void sortbyName()
        {
            int position, i;
            int length = names.Length;

            for ( position = 0; position < length - 1; position++)
            {
                for ( i = 0; i < length - position - 1; i++)
                {
                    int result = names[i].CompareTo(names[i +1]);
                    if (result == 1)
                    {
                        swapResult(i);
                    }
                } 
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        private void swapResult( int position)
        {
            //names
            string tempArr = names[position];
            names[position] = names[position + 1];
            names[position + 1] = tempArr;

            //phones
            tempArr = phones[position];
            phones[position] = phones[position + 1];
            phones[position + 1] = tempArr;

        }

        /// <summary>3,8
        /// 
        /// </summary>
        private void fillTable()
        {
            //looping through the single dimention array and insering the names and phone numbers from them into the two dimentional array!
            for (int i = 0; i < names.Length; i++)
            {
                phoneList[i, 0] = names[i];
                phoneList[i, 1] = phones[i];
            }      
        }

        /// <summary> 3,4
        /// Default Constructor: 
        /// This method is called as soon as the application is started. 
        /// </summary>
        public PhoneBook()
        {
            Console.Clear();// cleating the console so there is nothing old.

            //displaying the list of the tow arrays:
            displayList();

            //writing  an empty line.
            Console.WriteLine();

            //sorting:
            sortbyName();
            Console.WriteLine("Sorted List");

            displayList();

            //two dimensional array:
            int count = names.Length;//taking the value of who long the original array of names are:
            phoneList = new string[count, 2];//creating a new two-dimensinal array that have the same length as names plus 2 cloumes. 
            fillTable();//filling it with the valuse of the names and phones array. 

            Console.WriteLine("Using a 2d array instead of two 1 d arrays:");
            displayList();
        }
    }
}
