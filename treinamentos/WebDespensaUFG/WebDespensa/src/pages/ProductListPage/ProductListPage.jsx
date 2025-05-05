import React, { useState } from "react";
import Paper from '@material-ui/core/Paper';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import "./ProductListPage.css";
import AddProducts from "../../components/AddProducts/AddProducts";
import FilterProducts from "../../components/FilterProducts/FilterProducts";


function ProductListPage() {

  const [tabPosition, setTabPosition] = useState(0);

  const handleTabs = (value) => {
    setTabPosition(value);
    return;
  }

  const tabContent = [
    <AddProducts />,
    <FilterProducts />
  ];

  return (
    <div className="ProductListContainer">
      <Paper className="Paper">
        <Tabs
          value={tabPosition}
          onChange={(event, value) => { handleTabs(value) }}
          indicatorColor="primary"
          textColor="primary"
          centered
          variant="fullWidth"
        >
          <Tab label="Listar todos os produtos" value={0} />
          <Tab label="Filtrar lista de produtos" value={1} />
        </Tabs>
      </Paper>


        {tabContent[tabPosition]}
  
    </div>
  );
}

export default ProductListPage;