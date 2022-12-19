using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temp;
        private float humidity;
        private Subject weatherData;
        
        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registrObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temp 
                + "F degrees and " + humidity + "% humidity");
        }
    }
}
