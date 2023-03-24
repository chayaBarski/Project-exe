
import { useEffect, useState } from "react";
import { Grid, Label, Segment } from 'semantic-ui-react';
import { getAllProductsType } from '../service/Producrs';


function List(props) {
    const [ListP, setListP] = useState([]);

    useEffect(() => {
        start();
    }, []);
    const start = async () => {
        let res2 = await getAllProductsType()
        setListP(res2)
    }
   return(
        <div>
               <h1>--------------------1--------------</h1>
            {ListP.length > 0 ? ListP.map((p, i) => {
                return (

                    <Grid columns={1} key={i}>
                        <Grid.Row stretched>
                            <Grid.Column>
                                <Segment>
                                <Label color='red' horizontal>
                                        ProductType:{p.productType}
                                    </Label>

                                    <br />
                                    <Label color='red' horizontal>
                                        ProductTypeCount:{p.productTypeCount}
                                    </Label>
                                </Segment>
                            </Grid.Column>
                        </Grid.Row>
                    </Grid>)
            }) : ""}
        </div>
    );
}

export default List;
