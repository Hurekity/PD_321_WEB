
import './App.css';
import Article from '../article/Article';
import Header from '../header/Header';
import Footer from '../footer/Footer';
import Power from '../power/power';

function App() {
  return (
    <div className="App">
      <Header title="Hello React" description="This is my first React App"/>
      <Power a={2} n={8}/>
      <Article/>
      <Article/>
      <Footer/>
    </div>
  );
}
export default App;