using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieCustomerViewModel
    {
        public Movie movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}