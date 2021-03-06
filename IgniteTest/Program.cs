﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Cache.Query;
using Apache.Ignite.Linq;

namespace IgniteTest
{
    class Program
    {
        class Car
        {
            [QuerySqlField]
            public string Model { get; set; }

            [QuerySqlField]
            public int Power { get; set; }

            public override string ToString() => $"Model: {Model}, Power: {Power} hp";
        }

        static void Main(string[] args)
        {
            //using (var ignite = Ignition.Start())
            //{
            //    // Конфигурируем кэш для работы с SQL:
            //    var queryEntity = new QueryEntity(typeof(int), typeof(Car));
            //    var cacheConfig = new CacheConfiguration("cars", queryEntity);
            //    ICache<int, Car> cache = ignite.GetOrCreateCache<int, Car>(cacheConfig);

            //    // Вставка данных (_key - предопределённое поле):
            //    var insertQuery = new SqlFieldsQuery("INSERT INTO Car (_key, Model, Power) VALUES " +
            //                                         "(1, 'Ariel Atom', 350), " +
            //                                         "(2, 'Reliant Robin', 39)");
            //    cache.QueryFields(insertQuery).GetAll();

            //    // Запрос данных:
            //    //var selQuery = new SqlQuery(typeof(Car), "SELECT * FROM Car ORDER BY Power");
            //    //foreach (ICacheEntry<int, Car> entry in cache.Query(selQuery))
            //    //    Console.WriteLine(entry);

            //    // Запрос данных LINQ:
            //    var linqSelect = cache.AsCacheQueryable().OrderBy(c => c.Value.Power);
            //    foreach (ICacheEntry<int, Car> entry in linqSelect)
            //        Console.WriteLine(entry);
            //}

            //using (var ignite = Ignition.Start())
            //{
            //    // Конфигурируем кэш для работы с SQL:
            //    var queryEntity = new QueryEntity(typeof(int), typeof(Car));
            //    var cacheConfig = new CacheConfiguration("cars", queryEntity);
            //    ICache<int, Car> cache = ignite.GetOrCreateCache<int, Car>(cacheConfig);

            //    // Вставка данных (_key - предопределённое поле):
            //    //var insertQuery = new SqlFieldsQuery("INSERT INTO Car (_key, Model, Power) VALUES " +
            //    //                                     "(1, 'Ariel Atom', 350), " +
            //    //                                     "(2, 'Reliant Robin', 39)");
            //    //cache.QueryFields(insertQuery).GetAll();

            //    // Запрос данных:
            //    //var selQuery = new SqlQuery(typeof(Car), "SELECT * FROM Car ORDER BY Power");
            //    //foreach (ICacheEntry<int, Car> entry in cache.Query(selQuery))
            //    //    Console.WriteLine(entry);

            //    // Запрос данных LINQ:
            //    var linqSelect = cache.AsCacheQueryable().OrderBy(c => c.Value.Power);
            //    foreach (ICacheEntry<int, Car> entry in linqSelect)
            //        Console.WriteLine(entry);
            //}

            string str = "adas dasdjsakdjasdas asdas";
            
            Console.WriteLine(str.Substring(100));

            Console.ReadKey();
        }
    }
}
