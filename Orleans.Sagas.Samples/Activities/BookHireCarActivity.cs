﻿using System;
using System.Threading.Tasks;

namespace Orleans.Sagas.Samples.Activities
{
    public class BookHireCarActivity : Activity<BookHireCarConfig>
    {
        public override Task Compensate()
        {
            return Task.CompletedTask;
        }

        public override Task Execute()
        {
            return Task.CompletedTask;
        }
    }
}
