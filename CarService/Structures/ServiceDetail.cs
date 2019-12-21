using System;
using CarService.Attributes;

namespace CarService.Structures
{
    public class ServiceDetail
    {
        [VerboseName("Номер услуги")]
        public int Id { get; set; }

        [VerboseName("Клиент")]
        public User User { get; set; }

        [VerboseName("Модель машины")]
        public string CarModel { get; set; }

        [VerboseName("Описание поломки")]
        public string Description { get; set; }

        [VerboseName("Цена")]
        public float Cost { get; set; }

        [VerboseName("Дата и время")]
        public DateTime Datetime { get; set; }

        public override string ToString()
        {
            return $"{User} {Description} {Cost}";
        }
    }
}
