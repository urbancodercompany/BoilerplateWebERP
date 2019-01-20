using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BoilerplateWebERP.API.Models
{
    /*
    The main Client class
    Contains all property for the client structure
*/

    /// <summary>
    /// Model of Client.
    /// </summary>
    /// <returns>
    /// Model of client.
    /// </returns>

    public class Value
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }
    }
}