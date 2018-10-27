using System;


namespace LabWork_2
{
    /// <summary>
    /// Class Car
    /// This class for creating object Car
    /// </summary>
    
    public class Car
    {
        // It is a model of the car 
        // (getter and setter are created automaticaly)
        public string model { get; set; }

        // it is a brand of the car
        public string brand { get; set; }

        // and color of the car
        public string color { get; set; }

        /// <summary>
        /// Method Car
        /// is a constructor of objects Car
        /// </summary>
        /// <param name="Model">it is a model of the car</param>
        /// <param name="Brand">it is a brand of the car</param>
        /// <param name="Color">it is a color of the car</param>
        
        public Car(string Model, string Brand, string Color)
        {
            // Model, color and brand cant be empty strings
            if(Model == string.Empty || Brand == string.Empty || Color == string.Empty)
            {
                throw new Exception("Please, enter all data about car!");
            }
            else
            {
                model = Model;
                brand = Brand;
                color = Color;
            }
        }
    }
}
