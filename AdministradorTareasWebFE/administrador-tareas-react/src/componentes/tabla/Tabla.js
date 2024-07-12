import React, { useEffect, useState } from 'react'
import axios from 'axios'
import DataTable from 'react-data-table-component'

function Tabla() {
    const columnas = [
        {   
            name: 'Descripción',
            selector: fila => fila.descripcion
        },
        {
            name: 'Colaborador',
            selector: fila => fila.idColaborador
        },
        {
            name: 'Estado',
            selector: fila => fila.estado
        },
        {
            name: 'Prioridad',
            selector: fila => fila.prioridad
        },
        {
            name: 'Fecha Inicial',
            selector: fila => fila.fechaInicio
        },
        {
            name: 'Fecha Final',
            selector: fila => fila.fechaFin
        },
    ];
    const [resultado, setResultado] = useState([]);
    useEffect(() => {
        fetch("https://administadortareasapi.azurewebsites.net/api/Tarea/Lista")
        .then((respuesta) => {
            return respuesta.json();
        })
        .then((resultado) => {
            console.log(resultado);
            setResultado(resultado.respuesta);
        });
    }, []);
    
    return (
        <div>
            <DataTable
                columns={columnas}
                noDataComponent = 'd'
                 data={resultado}
                />
        </div>
    )
}

export default Tabla;