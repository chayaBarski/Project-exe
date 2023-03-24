
import { useEffect, useState } from "react";
import { Grid, Label, Segment } from 'semantic-ui-react';
import { getAllProductsTypeAndSum } from '../service/Producrs';


function ListP() {
    const [ListP, setListP] = useState([]);

    useEffect(() => {
        start();
    }, []);
    const start = async () => {
        console.log("hello");
        let res2 = await getAllProductsTypeAndSum()
        setListP(res2)
    }
    return (
        <div>
            <h1>--------------------2--------------</h1>
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

export default ListP;
