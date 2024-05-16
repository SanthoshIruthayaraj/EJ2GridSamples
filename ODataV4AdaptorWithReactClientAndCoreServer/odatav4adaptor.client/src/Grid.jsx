import {
  GridComponent,
  ColumnsDirective,
  ColumnDirective,
  Inject,
  Page,
  Sort,
  Filter,
  Edit,
  Toolbar
} from "@syncfusion/ej2-react-grids";
import { DataManager, ODataV4Adaptor } from "@syncfusion/ej2-data";

function Grid() {
  const data = new DataManager({
    url: "https://localhost:44337/odata/Orders",
    adaptor: new ODataV4Adaptor(),
  });

  return (
    <div>
      <GridComponent
        id="grid"
        dataSource={data}
        allowPaging={true}
        allowSorting={true}
        allowFiltering={true}
        editSettings={{
          allowEditing: true,
          allowAdding: true,
          allowDeleting: true,
        }}
        toolbar={['Add', 'Edit', 'Delete', 'Update', 'Cancel', 'Search']}
      >
        <ColumnsDirective>
          <ColumnDirective
            field="OrderID"
            headerText="Order ID"
            width="120"
            textAlign="Right"
            isPrimaryKey={true}
          ></ColumnDirective>
          <ColumnDirective
            field="CustomerID"
            headerText="Customer ID"
            width="150"
          ></ColumnDirective>
          <ColumnDirective
            field="EmployeeID"
            headerText="Employee ID"
            width="150"
          ></ColumnDirective>
          <ColumnDirective
            field="ShipCountry"
            headerText="Ship Country"
            width="150"
          ></ColumnDirective>
        </ColumnsDirective>
        <Inject services={[Page, Sort, Filter, Edit, Toolbar]} />
      </GridComponent>
    </div>
  );
}

export default Grid;
