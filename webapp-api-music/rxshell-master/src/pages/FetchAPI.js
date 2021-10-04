import React from "react";
import axios from 'axios';


class FetchAPI extends React.Component{
    constructor(props){
        super(props);
        this.state = {
            data : []
        }
    }

    componentDidMount() {
        const { apiUrl } = this.props;
        axios.get(apiUrl)
          .then(res => {
              console.log(res.data);
              this.setState({
                  data : res.data
              })
          })
      }

    render(){
        const {data} = this.state;
        return <div dangerouslySetInnerHTML={ {__html: data} }></div>
    }
}


export default FetchAPI;