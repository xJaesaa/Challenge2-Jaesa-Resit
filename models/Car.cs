namespace CivSem1Challenge2_CarSystem.models {

    public class Car {

        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public int DealerId { get; set; }

        public Car (string registration, string make, string model, int yearOfManufacture, int dealerId) {
            Registration = registration;
            Make = make;
            Model = model;
            YearOfManufacture = yearOfManufacture;
            DealerId = dealerId;
        }

        public string GetDetails() {
            //TODO: complete the below to return the Make and Model of a car
            return $"Make: {this.Make}, Model: {this.Model}, Year Of Manufacture {this.YearOfManufacture}";
        }

    }
}
