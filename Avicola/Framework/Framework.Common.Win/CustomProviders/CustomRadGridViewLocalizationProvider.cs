﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Framework.Common.Win.CustomProviders
{
    public class CustomRadGridViewLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.AddNewRowString:
                    return "Clic aquí para agregar una fila";
                case RadGridStringId.BestFitMenuItem:
                    return "Ajustar al contenido";
                case RadGridStringId.ClearSortingMenuItem:
                    return "Re-ordenar";
                case RadGridStringId.ClearValueMenuItem:
                    return "Limpiar celda";
                case RadGridStringId.ColumnChooserFormCaption:
                    return "Selector de columnas";
                case RadGridStringId.ColumnChooserFormMessage:
                    return "Para ocultar una columna," + "\r\n" + " arrastre hacia esta ventana.";
                case RadGridStringId.ColumnChooserMenuItem:
                    return "Selector de columnas";
                case RadGridStringId.ConditionalFormattingBtnAdd:
                    return "Agregar";
                case RadGridStringId.ConditionalFormattingBtnApply:
                    return "Aplicar";
                case RadGridStringId.ConditionalFormattingBtnCancel:
                    return "Cancelar";
                case RadGridStringId.ConditionalFormattingBtnOK:
                    return "Aceptar";
                case RadGridStringId.ConditionalFormattingBtnRemove:
                    return "Quitar";
                case RadGridStringId.ConditionalFormattingCaption:
                    return "Configurar formato condicional";
                case RadGridStringId.ConditionalFormattingChkApplyToRow:
                    return "Aplicar a toda la fila";
                case RadGridStringId.ConditionalFormattingChooseOne:
                    return "Seleccione una opción";
                case RadGridStringId.ConditionalFormattingContains:
                    return "Contiene";
                case RadGridStringId.ConditionalFormattingDoesNotContain:
                    return "No contiene";
                case RadGridStringId.ConditionalFormattingEndsWith:
                    return "Termina";
                case RadGridStringId.ConditionalFormattingEqualsTo:
                    return "Igual";
                case RadGridStringId.ConditionalFormattingGrpConditions:
                    return "Condiciones";
                case RadGridStringId.ConditionalFormattingGrpProperties:
                    return "Propiedades";
                case RadGridStringId.ConditionalFormattingIsBetween:
                    return "Entre";
                case RadGridStringId.ConditionalFormattingIsGreaterThan:
                    return "Mayor";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual:
                    return "Mayor igual";
                case RadGridStringId.ConditionalFormattingIsLessThan:
                    return "Menor";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual:
                    return "Menor igual";
                case RadGridStringId.ConditionalFormattingIsNotBetween:
                    return "No entre";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo:
                    return "No igual";
                case RadGridStringId.ConditionalFormattingLblColumn:
                    return "Columna:";
                case RadGridStringId.ConditionalFormattingLblName:
                    return "Nombre:";
                case RadGridStringId.ConditionalFormattingLblType:
                    return "Tipo:";
                case RadGridStringId.ConditionalFormattingLblValue1:
                    return "Valor 1:";
                case RadGridStringId.ConditionalFormattingLblValue2:
                    return "Valor 2:";
                case RadGridStringId.ConditionalFormattingMenuItem:
                    return "Formato condicional";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn:
                    return "Aplicar regla para";
                case RadGridStringId.ConditionalFormattingStartsWith:
                    return "Inicia";
                case RadGridStringId.CopyMenuItem:
                    return "Copiar";
                case RadGridStringId.CustomFilterDialogBtnCancel:
                    return "Cancelar";
                case RadGridStringId.CustomFilterDialogBtnOk:
                    return "Aceptar";
                case RadGridStringId.CustomFilterDialogCaption:
                    return "Personalizar filtro";
                case RadGridStringId.CustomFilterDialogCheckBoxNot:
                    return "No";
                case RadGridStringId.CustomFilterDialogLabel:
                    return "Criterios de filtrado";
                case RadGridStringId.CustomFilterDialogRbAnd:
                    return "Y";
                case RadGridStringId.CustomFilterDialogRbOr:
                    return "O";
                case RadGridStringId.CustomFilterMenuItem:
                    return "Personalizar filtro";
                case RadGridStringId.DeleteRowMenuItem:
                    return "Eliminar fila";
                case RadGridStringId.EditMenuItem:
                    return "Editar celda";
                case RadGridStringId.FilterFunctionBetween:
                    return "Entre";
                case RadGridStringId.FilterFunctionContains:
                    return "Contiene";
                case RadGridStringId.FilterFunctionCustom:
                    return "Personalizar";
                case RadGridStringId.FilterFunctionDoesNotContain:
                    return "No contiene";
                case RadGridStringId.FilterFunctionEndsWith:
                    return "Termina";
                case RadGridStringId.FilterFunctionEqualTo:
                    return "Igual";
                case RadGridStringId.FilterFunctionGreaterThan:
                    return "Mayor";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo:
                    return "Mayor igual";
                case RadGridStringId.FilterFunctionIsEmpty:
                    return "Vacios";
                case RadGridStringId.FilterFunctionIsNull:
                    return "Nulos";
                case RadGridStringId.FilterFunctionLessThan:
                    return "Menor";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo:
                    return "Menor igual";
                case RadGridStringId.FilterFunctionNoFilter:
                    return "Sin filtrar";
                case RadGridStringId.FilterFunctionNotBetween:
                    return "No entre";
                case RadGridStringId.FilterFunctionNotEqualTo:
                    return "No igual";
                case RadGridStringId.FilterFunctionNotIsEmpty:
                    return "No vacio";
                case RadGridStringId.FilterFunctionNotIsNull:
                    return "No nulo";
                case RadGridStringId.FilterFunctionStartsWith:
                    return "Inicia";
                case RadGridStringId.FilterOperatorBetween:
                    return "Entre";
                case RadGridStringId.FilterOperatorContains:
                    return "Contiene";
                case RadGridStringId.FilterOperatorCustom:
                    return "Personalizado";
                case RadGridStringId.FilterOperatorDoesNotContain:
                    return "No contiene";
                case RadGridStringId.FilterOperatorEndsWith:
                    return "Termina";
                case RadGridStringId.FilterOperatorEqualTo:
                    return "Igual";
                case RadGridStringId.FilterOperatorGreaterThan:
                    return "Mayor";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo:
                    return "Mayor igual";
                case RadGridStringId.FilterOperatorIsContainedIn:
                    return "Contiene en";
                case RadGridStringId.FilterOperatorIsEmpty:
                    return "Vacio";
                case RadGridStringId.FilterOperatorIsLike:
                    return "Es como";
                case RadGridStringId.FilterOperatorIsNull:
                    return "Nulo";
                case RadGridStringId.FilterOperatorLessThan:
                    return "Menor";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo:
                    return "Menor igual";
                case RadGridStringId.FilterOperatorNoFilter:
                    return "Sin filtrar";
                case RadGridStringId.FilterOperatorNotBetween:
                    return "No entre";
                case RadGridStringId.FilterOperatorNotEqualTo:
                    return "No igual";
                case RadGridStringId.FilterOperatorNotIsContainedIn:
                    return "No contiene en";
                case RadGridStringId.FilterOperatorNotIsEmpty:
                    return "No vacio";
                case RadGridStringId.FilterOperatorNotIsLike:
                    return "No como";
                case RadGridStringId.FilterOperatorNotIsNull:
                    return "No nulo";
                case RadGridStringId.FilterOperatorStartsWith:
                    return "Inicia";
                case RadGridStringId.GroupByThisColumnMenuItem:
                    return "Agrupar columna";
                case RadGridStringId.GroupingPanelDefaultMessage:
                    return "Arrastrar aquí el encabezado de columna para agrupar";
                case RadGridStringId.GroupingPanelHeader:
                    return "Columnas agrupadas";
                case RadGridStringId.HideMenuItem:
                    return "Ocultar columna";
                case RadGridStringId.NoDataText:
                    return "No hay datos para mostrar";
                case RadGridStringId.PasteMenuItem:
                    return "Pegar";
                case RadGridStringId.PinAtLeftMenuItem:
                    return "Aplilar a la izquierda";
                case RadGridStringId.PinAtRightMenuItem:
                    return "Apilar a la derecha";
                case RadGridStringId.PinMenuItem:
                    return "Apilar";
                case RadGridStringId.SortAscendingMenuItem:
                    return "Ordenar Ascendente";
                case RadGridStringId.SortDescendingMenuItem:
                    return "Ordenar Descendente";
                case RadGridStringId.UngroupThisColumn:
                    return "Desagrupar columna";
                case RadGridStringId.UnpinMenuItem:
                    return "Desapilar";
                case RadGridStringId.PagingPanelPagesLabel:
                    return "Pag.";
                case RadGridStringId.PagingPanelOfPagesLabel:
                    return "de";
                default:
                    return base.GetLocalizedString(id);
            }
        }

    }
}