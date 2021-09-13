import { getUserDetails, getAllUsers } from './requests';

// class UsersList extends React.Component {
//   constructor(props) {
// 	//...
//   }

//   //...

//   handleUserSelection = (userId) => {
// 	this.setState({userId});
// 	getUserDetails(this.state.userId, this.handleUserDetailsResponse);
//   }

//   //...

//   render() {
// 	return (
//   	<div>
//     	{/* ... */}
//   	</div>
// 	);
//   }
// }

const UsersList = () => {
  const { data, isLoading } = useQuery(getAllUsers)
  const history = useHistory()

  if (isLoading) return <Spinner />

  const handleUserSelection = (userId) =>  history.push(Routes.userDetailsScreen(userId))


  return <>
    {/* ... use data here */}
  </>
}
