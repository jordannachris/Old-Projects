import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import Typography from "@material-ui/core/Typography";
import IconButton from "@material-ui/core/IconButton";
import MenuIcon from "@material-ui/icons/Menu";
import Drawer from "@material-ui/core/Drawer";
import List from "@material-ui/core/List";
import Divider from "@material-ui/core/Divider";
import ChevronLeftIcon from "@material-ui/icons/ChevronLeft";
import ListItem from "@material-ui/core/ListItem";
import ListItemIcon from "@material-ui/core/ListItemIcon";
import ListItemText from "@material-ui/core/ListItemText";
import HomeOutlinedIcon from '@material-ui/icons/HomeOutlined';
import ListAltIcon from '@material-ui/icons/ListAlt';
import FaceIcon from '@material-ui/icons/Face';

import { NavLink } from "react-router-dom";

const useStyles = makeStyles((theme) => ({
  list: {
    width: 250,
  },
  header: {
    display: "flex",
    justifyContent: "space-between",
    width: "100vw",
  },
  login:{
    color: "white",
    textDecoration: "none",
  },
  drawerHeader: {
    display: "flex",
    alignItems: "center",
    justifyContent: "flex-end",
  },
  main: {
    padding: theme.spacing(3),
  },
}));

export default function MenuPageTemplate(props) {

  const classes = useStyles();

  const [open, setOpen] = React.useState(false);


  const handleDrawerOpen = () => {
    setOpen(true);
  };

  const handleDrawerClose = () => {
    setOpen(false);
  };

  return (
    <div>
      <AppBar position="sticky">
        <Toolbar>
          <IconButton
            edge="start"
            color="inherit"
            aria-label="menu"
            onClick={handleDrawerOpen}
          >
            <MenuIcon />
          </IconButton>
          <div className={classes.header}>
            <Typography variant="h6">Web Despensa</Typography>
            <Typography className={classes.login} component={NavLink} to="/usuario/login" variant="h6">Login</Typography>
          </div>
        </Toolbar>
      </AppBar>
      <Drawer anchor="left" open={open} onClose={handleDrawerClose}>
        <div className={classes.list}>
          <div className={classes.drawerHeader}>
            <IconButton onClick={handleDrawerClose}>
              <ChevronLeftIcon />
            </IconButton>
          </div>
          <Divider />
          <List>
            <ListItem component={NavLink} to="/">
              <ListItemIcon>
                <HomeOutlinedIcon />
              </ListItemIcon>
              <ListItemText primary="Home" />
            </ListItem>

            <ListItem component={NavLink} to="/produto/lista">
              <ListItemIcon>
                <ListAltIcon />
              </ListItemIcon>
              <ListItemText primary="Lista de produtos" />
            </ListItem>

            <ListItem component={NavLink} to="/usuario/info">
              <ListItemIcon>
                <FaceIcon />
              </ListItemIcon>
              <ListItemText primary="Minha conta" />
            </ListItem>
          </List>
        </div>
      </Drawer>
      <main className={classes.main}>
        <div className="ConteudoPrincipalAQUI">{props.children}</div>
      </main>
    </div>
  );
}
