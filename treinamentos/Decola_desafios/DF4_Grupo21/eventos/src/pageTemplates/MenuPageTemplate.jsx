import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import { NavLink } from "react-router-dom";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import Drawer from "@material-ui/core/Drawer";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import Divider from "@material-ui/core/Divider";
import Typography from "@material-ui/core/Typography";
import IconButton from "@material-ui/core/IconButton";
import MenuIcon from "@material-ui/icons/Menu";
import ChevronLeftIcon from "@material-ui/icons/ChevronLeft";
import ListItemIcon from "@material-ui/core/ListItemIcon";
import ListItemText from "@material-ui/core/ListItemText";
import HomeIcon from "@material-ui/icons/Home";
import ChatBubbleOutlineIcon from "@material-ui/icons/ChatBubbleOutline";
import EventIcon from "@material-ui/icons/Event";
import AddCircleOutlineIcon from "@material-ui/icons/AddCircleOutline";
import PeopleOutlineIcon from "@material-ui/icons/PeopleOutline";
import { createTheme } from "@material-ui/core/styles";
import { ThemeProvider } from "@material-ui/styles";
import Collapse from '@material-ui/core/Collapse';
import ExpandLess from '@material-ui/icons/ExpandLess';
import ExpandMore from '@material-ui/icons/ExpandMore';
import SearchIcon from '@material-ui/icons/Search';

const useStyles = makeStyles(() => ({
  list: {
    width: 250,
    textDecoration: "none",
    color: "#051C6B"
  },
  drawerHeader: {
    display: "flex",
    alignItems: "center",
    justifyContent: "flex-start",
  },
  nested: {
    paddingLeft: theme.spacing(4),
  },
  icon: {
    color: "#ff9100"
  }
}));

const theme = createTheme({
  palette: {
    primary: {
      main: "#051C6B",
    },
    secondary: {
      main: "#fff",
    },
  },

  typography: {
    fontFamily: "Poppins",
  },
});

export default function MenuPageTemplate(props) {
  const classes = useStyles();

  const [open, setOpen] = React.useState(false);

  const handleDrawerOpen = () => {
    setOpen(true);
  };

  const handleDrawerClose = () => {
    setOpen(false);
  };

  const [opcaoFiltrarAberto, setOpcaoFiltrarAberto] = React.useState(true);
  const handleClickSubMenu = () => {
    setOpcaoFiltrarAberto(!opcaoFiltrarAberto);
  };

  return (
    <div>
      <ThemeProvider theme={theme}>
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
            <Typography variant="h6">Evente-se</Typography>
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

            <List className={classes.list}>

              <ListItem component={NavLink} to="/">
                <ListItemIcon>
                  <HomeIcon style={{ color: '#075FBC' }}/>
                </ListItemIcon>
                <ListItemText className={classes.list} primary="Home" />
              </ListItem>

              <ListItem component={NavLink} to="/eventos-disponiveis">
                <ListItemIcon>
                  <EventIcon style={{ color: '#075FBC' }}/>
                </ListItemIcon>
                <ListItemText className={classes.list} primary="Eventos disponíveis" />
              </ListItem>

              <ListItem component={NavLink} to="/avaliate">
                <ListItemIcon>
                  <ChatBubbleOutlineIcon  style={{ color: '#075FBC' }}/>
                </ListItemIcon>
                <ListItemText className={classes.list} primary="Comentários" />
              </ListItem>

              <ListItem component={NavLink} to="/cadastrar">
                <ListItemIcon>
                  <AddCircleOutlineIcon  style={{ color: '#075FBC' }}/>
                </ListItemIcon>
                <ListItemText className={classes.list} primary="Cadastrar eventos" />
              </ListItem>

              <ListItem component={NavLink} to="/participantes">
                <ListItemIcon>
                  <PeopleOutlineIcon style={{ color: '#075FBC' }} />
                </ListItemIcon>
                <ListItemText className={classes.list} primary="Lista de participantes" />
              </ListItem>

              <ListItem button onClick={handleClickSubMenu}>
                <ListItemIcon>
                  <SearchIcon style={{ color: '#075FBC' }} />
                </ListItemIcon>
                <ListItemText primary="Filtrar eventos" />
                {opcaoFiltrarAberto ? <ExpandLess /> : <ExpandMore />}
              </ListItem>
              <Collapse in={opcaoFiltrarAberto} timeout="auto" unmountOnExit>
                <List component="div" disablePadding>

                  <ListItem button className={classes.nested} component={NavLink} to="/eventos/categoria">
                    <ListItemText primary="Por categoria" />
                  </ListItem>

                  <ListItem button className={classes.nested} component={NavLink} to="/eventos/data">
                    <ListItemText primary="Por data" />
                  </ListItem>

                </List>
              </Collapse>

            </List>
          </div>
        </Drawer>
        <main className={classes.main}>
          <div className="ConteudoPrincipalAQUI">{props.children}</div>
        </main>
      </ThemeProvider>
    </div>
  );
}
