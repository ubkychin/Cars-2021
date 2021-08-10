using System;

namespace CarsLib {
    public class Car {
        
        public string Rego { get; set; }
        public int Speed { get; set; }

        public Car (string rego, int speed) {
            this.SetRego(rego);
            this.Speed = speed;

        }

        /// <summary>
        /// sets Rego and makes sure that its exactly 6 characters
        /// </summary>
        /// <param name="rego"></param>
        public void SetRego(string rego) {
            if (rego.Length < 6) {
                // add A until rego is 6 in length
                while (rego.Length < 6) {
                    rego += "A";
                }
            } else if (rego.Length > 6) {
                while (rego.Length > 6) {
                    // removes the last character from a string
                    rego = rego.Remove(rego.Length-1);
                }
            }

            this.Rego = rego;
        }

        /// <summary>
        /// sets Speed.  Ensures that speed is between 130 and -10 inclusive
        /// </summary>
        /// <param name="speed"></param>
        public void AddSpeed(int speed) {
            this.Speed += speed;

            if (this.Speed > 130) {
                this.Speed = 130;
            } else if (this.Speed < -10) {
                this.Speed = -10;
            }
        }
    }
}