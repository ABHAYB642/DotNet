import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { products: [], loading: true };
  }

  componentDidMount() {
    this.populateProductsData();
  }

  static renderProductTable(products) {
    return (
              products.map(product =><p>{product.title} {product.description}</p>
          ) 
    );
  }

  render() {
    let contents =  FetchData.renderProductTable(this.state.products);

    return (
      <div>
        <h1 id="tableLabel">Product Catalog</h1>
      </div>
    );
  }

  async populateProductsData() {
    const response = await fetch('products');
    const data = await response.json();
    this.setState({ products: data, loading: false });
  }
}
