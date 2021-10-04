import React from "react";
import PropTypes from "prop-types";
import { withStyles } from "@material-ui/core/styles";
import FetchAPI from "./FetchAPI";

const styles = theme => ({
  root: {
    display: "flex",
    flexWrap: "wrap",
    justifyContent: "space-around",
    overflow: "hidden",
    backgroundColor: theme.palette.background.paper,
    marginTop: '100px'
  }
});

function Home(props) {
  const { classes } = props;

  return (
      <div className={classes.root}>
        <FetchAPI apiUrl = "http://localhost:5000/Music/unfaithful"/>
        <FetchAPI apiUrl = "http://localhost:5000/Music/believer"/>
        <FetchAPI apiUrl = "http://localhost:5000/Music/trampoline"/>
        
      </div>
  );
}

Home.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(styles)(Home);
