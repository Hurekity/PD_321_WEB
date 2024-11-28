
import './App.css';
import Header from '../header/Header';
import Nav from '../nav/Nav';
import Power from '../power/power';
import Article from '../article/Article';
import Footer from '../footer/Footer';
import data from '../article/db.json';

function App() {

  let nav = 
  {
    "Main" : "/index",
    "News" : "/news",
    "Store" : "/shop",
    "About us" : "/about",
    "Contacts" : "/contacts",
  } //that's an array
  
let db = data;

  return (
    <div className="App">
      <Header title="Hello React" description="This is my first React App"/>
      <Nav navigation = {nav}/>
      <Power a={2} n={8}/>
      <Article db = {db}/>
      <Footer/>
    </div>
  );
}
export default App;