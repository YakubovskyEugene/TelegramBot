﻿using Domain.Primitives;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Класс Человек
    /// </summary>
    public class Person : BaseEntity
    {
        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Person()
        {

        }
        /// <summary>
        /// ФИО человека
        /// </summary>
        public FullName FullName { get; set; }
        /// <summary>
        /// Дата рождения человека
        /// </summary>
        public DateTime Birthday { get; private set; }
        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthday.Year;
                if (DateTime.Now < Birthday.AddYears(age))
                    age--;
                return age;
            }
        }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Кастомные поля
        /// </summary>
        public List<CustomField> CustomFields { get; set; }
    }
}
