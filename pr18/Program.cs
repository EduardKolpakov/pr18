namespace DistanceLibrary
{
    /// <summary>
    /// Класс для работы с расстоянием.
    /// Расстояние хранится в метрах
    /// </summary>
    public class Distance
    {
        private double _distance;

        /// <summary>
        /// Создаёт новый объект Distance
        /// с указанным расстоянием в метрах
        /// </summary>
        /// <param name="distance">Исходное 
        /// расстояние в метрах</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Если расстояние меньше нуля
        /// </exception>
        public Distance(double distance)
        {
            if (distance < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(distance),
                    "Расстояние не может быть отрицательным"
                );
            }

            _distance = distance;
        }

        /// <summary>
        /// Возвращает текущее расстояние в метрах
        /// </summary>
        public double DistanceInMeters => _distance;

        /// <summary>
        /// Изменяет расстояние на указанную величину
        /// </summary>
        /// <param name="delta">На сколько изменяется 
        /// расстояние</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Если новое расстояние меньше нуля
        /// </exception>
        public void ChangeDistance(double delta)
        {
            double newDistance = _distance + delta;

            if (newDistance < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(delta),
                    "Новое расстояние не может быть отрицательным"
                );
            }

            _distance = newDistance;
        }

        /// <summary>
        /// Переводит расстояние в сантиметры
        /// </summary>
        /// <returns>Расстояние в сантиметрах</returns>
        public double ToCentimeters()
        {
            return _distance * 100;
        }

        /// <summary>
        /// Переводит расстояние в километры
        /// </summary>
        /// <returns>Расстояние в километрах</returns>
        public double ToKilometers()
        {
            return _distance / 1000;
        }
    }
}