/*
С помощью паттерна Состояние сделайте модель работы
светофора с регулируемыми задержками переключения цвета.
*/

using Main;

TrafficLight trafficLight = new TrafficLight(new StateRed());

trafficLight.DisplayColor();
trafficLight.DisplayColor(2000);
trafficLight.DisplayColor(500);
trafficLight.DisplayColor(5000);