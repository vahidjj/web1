using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using report_as_pdf.Models;

namespace report_as_pdf.Irepcustomer
{
    public interface icustomerrep
    {
        List<Customer> GetCustomers();
    }
}
