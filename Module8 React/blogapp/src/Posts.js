// JavaScript source code
// Posts.js
import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
    constructor(props) {
        super(props);
        this.state = {
            posts: [],
        };
    }

    loadPosts = () => {
        fetch('https://jsonplaceholder.typicode.com/posts')
            .then(response => response.json())
            .then(data => {
                const postObjects = data.map(
                    item => new Post(item.userId, item.id, item.title, item.body)
                );
                this.setState({ posts: postObjects });
            })
            .catch(error => {
                alert("Failed to fetch posts: " + error.message);
            });
    };

    componentDidMount() {
        this.loadPosts();
    }

    componentDidCatch(error, info) {
        alert("An error occurred: " + error);
    }

    render() {
        return (
            <div>
                <h1>All Blog Posts</h1>
                {this.state.posts.map(post => (
                    <div key={post.id}>
                        <h2>{post.title}</h2>
                        <p>{post.body}</p>
                        <hr />
                    </div>
                ))}
            </div>
        );
    }
}

export default Posts;

