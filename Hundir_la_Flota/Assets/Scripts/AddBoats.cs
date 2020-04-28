﻿using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class AddBoats : MonoBehaviour
{

    public InputField inputCols;
    public InputField inputRows;
    public Dropdown boats;
    public Dropdown positions;
    public GameObject myGrid;
    public GameObject gridSquare;
    private int cols;
    private int rows;

    private List<GameObject> gridSquares;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void getGridDimmensions()
    {
        int c = 0, r = 0;

        c = myGrid.GetComponent<Grid>().getCol();
        r = myGrid.GetComponent<Grid>().getRows();


        Debug.Log("Nuestro Grid tiene " + c + " columnas y " + r + "filas.");
    }

    public void getInputfields()
    {
        gridSquares = myGrid.GetComponent<Grid>().gridSquare();

        if (getCols() && getRows())
        {
            PlaceBoat(cols, rows);
            Debug.Log("Has seleccionado la Columna:" + cols + " Fila: " + rows);
        }
        else
        {
            EditorUtility.DisplayDialog("Error", "Introduzca una columna/fila correcta", "aceptar");
        }
    }

    private bool getCols()
    {
        if (inputCols.text == string.Empty)
        {
            return false;
        }
        else
        {
            return controlCol(inputCols.text);
        }
    }

    private bool getRows()
    {
        if ((inputRows.text == string.Empty))
        {
            return false;
        }
        else
        {
            return vocalToInt(inputRows.text);
        }
    }

    private void PlaceBoat(int c, int r)
    {
        //foreach(GameObject gridSquare in gridSquares)
        //{
        //    if(((cols-1) == gridSquare.GetComponent<GridSquare>().getCol()) && ((rows-1)  == gridSquare.GetComponent<GridSquare>().getRow()))
        //    {
        //        this.gridSquare.GetComponent<Image>().color = Color.gray;
        //        this.gridSquare.GetComponent<GridSquare>().setValue(1);
        //    }
        //}

        for (int ro = 0; ro < 10; ro++)
        {
            for (int co = 0; co < 10; co++)
            {
                if (((c - 1) == gridSquare.GetComponent<GridSquare>().getCol()) && ((r - 1) == gridSquare.GetComponent<GridSquare>().getRow()))
                {
                    this.gridSquare.GetComponent<Image>().color = Color.white;
                    this.gridSquare.GetComponent<GridSquare>().setValue(1);
                }
            }
        }


    }

    private bool vocalToInt(string vocal)
    {
        if (vocal.ToUpper().Equals("A"))
        {
            rows = 1;
            return true;
        }
        else if (vocal.ToUpper().Equals("B"))
        {
            rows = 2;
            return true;
        }
        else if (vocal.ToUpper().Equals("C"))
        {
            rows = 3;
            return true;
        }
        else if (vocal.ToUpper().Equals("D"))
        {
            rows = 4;
            return true;
        }
        else if (vocal.ToUpper().Equals("E"))
        {
            rows = 5;
            return true;
        }
        else if (vocal.ToUpper().Equals("F"))
        {
            rows = 6;
            return true;
        }
        else if (vocal.ToUpper().Equals("G"))
        {
            rows = 7;
            return true;
        }
        else if (vocal.ToUpper().Equals("H"))
        {
            rows = 8;
            return true;
        }
        else if (vocal.ToUpper().Equals("I"))
        {
            rows = 9;
            return true;
        }
        else if (vocal.ToUpper().Equals("J"))
        {
            rows = 10;
            return true;
        }
        return false;
    }

    private bool controlCol(string columna)
    {
        int c = Int32.Parse(columna);
        if ((c > 0) && (c < 11))
        {
            cols = c;
            return true;
        }

        return false;
    }
}
