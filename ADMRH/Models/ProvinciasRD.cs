using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMRH.Models
{
    public class ProvinciasRD
    {
        public string GetProvincias()
        {
            string provincia = @"{
                'status': 200,
                'data': [
                    {
                            'codigo': 1,
                        'nombre': 'Azua'
                    },
                    {
                            'codigo': 2,
                        'nombre': 'Bahoruco'
                    },
                    {
                            'codigo': 3,
                        'nombre': 'Barahona'
                    },
                    {
                            'codigo': 4,
                        'nombre': 'Dajabón'
                    },
                    {
                            'codigo': 5,
                        'nombre': 'Distrito Nacional'
                    },
                    {
                            'codigo': 6,
                        'nombre': 'Duarte'
                    },
                    {
                            'codigo': 7,
                        'nombre': 'Elías Piña'
                    },
                    {
                            'codigo': 8,
                        'nombre': 'El Seibo'
                    },
                    {
                            'codigo': 9,
                        'nombre': 'Espaillat'
                    },
                    {
                            'codigo': 10,
                        'nombre': 'Hato Mayor'
                    },
                    {
                            'codigo': 11,
                        'nombre': 'Hermanas Mirabal'
                    },
                    {
                            'codigo': 12,
                        'nombre': 'Independencia'
                    },
                    {
                            'codigo': 13,
                        'nombre': 'La Altagracia'
                    },
                    {
                            'codigo': 14,
                        'nombre': 'La Romana'
                    },
                    {
                            'codigo': 15,
                        'nombre': 'La Vega'
                    },
                    {
                            'codigo': 16,
                        'nombre': 'María Trinidad Sánchez'
                    },
                    {
                            'codigo': 17,
                        'nombre': 'Monseñor Nouel'
                    },
                    {
                            'codigo': 18,
                        'nombre': 'Monte Cristi'
                    },
                    {
                            'codigo': 19,
                        'nombre': 'Monte Plata'
                    },
                    {
                            'codigo': 20,
                        'nombre': 'Pedernales'
                    },
                    {
                            'codigo': 21,
                        'nombre': 'Peravia'
                    },
                    {
                            'codigo': 22,
                        'nombre': 'Puerto Plata'
                    },
                    {
                            'codigo': 23,
                        'nombre': 'Samaná'
                    },
                    {
                            'codigo': 24,
                        'nombre': 'Sánchez Ramírez'
                    },
                    {
                            'codigo': 25,
                        'nombre': 'San Cristóbal'
                    },
                    {
                            'codigo': 26,
                        'nombre': 'San José de Ocoa'
                    },
                    {
                            'codigo': 27,
                        'nombre': 'San Juan'
                    },
                    {
                            'codigo': 28,
                        'nombre': 'San Pedro de Macorís'
                    },
                    {
                            'codigo': 29,
                        'nombre': 'Santiago'
                    },
                    {
                            'codigo': 30,
                        'nombre': 'Santiago Rodríguez'
                    },
                    {
                            'codigo': 31,
                        'nombre': 'Santo Domingo'
                    },
                    {
                            'codigo': 32,
                        'nombre': 'Valverde'
                    }
                ]
            }";
            return provincia;
        }
    }
}
